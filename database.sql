go
create database box_database;

go
use box_database;

go
create table box_dimension
(
	[id] int identity(1, 1) not null,
	[width] float not null,
	[height] float not null,
	[depth] float not null,

	primary key ([id]),
	constraint uq_box_size unique ([width], [height], [depth]),
	constraint chk_height_over_zero check ([height] > 0),
	constraint chk_width_over_zero check ([width] > 0),
	constraint chk_depth_over_zero check ([depth] > 0)
)

go
create table box
(
	[id] int identity(1, 1) not null,
	[dimension_id] int null,
	[fullness_percentage] float null,
	[main_box_id] int null,
	[label] nvarchar(25) not null,
	[maximum_weight] float null,
	
	primary key ([id]),
	constraint fk_box_dimension foreign key ([dimension_id]) references box_dimension([id]),
	constraint fk_main_box foreign key ([main_box_id]) references box([id]),
	constraint chk_maximum_weight_over_zero check ([maximum_weight] > 0)
)

go
create table item
(
	[id] int identity(1, 1) not null,
	[box_id] int not null,
	[description] nvarchar(40) not null,
	[weight] float null,

	primary key ([id]),
	constraint fk_box_item foreign key ([box_id]) references box([id]),
	constraint chk_weight_over_zero check ([weight] > 0)
)

go
create table item_toy
(
	[item_id] int identity (1, 1) not null,
	[minimum_age] int null

	primary key ([item_id]),
	constraint fk_item_item_toy foreign key ([item_id]) references item([id]),
	constraint chk_age_over_zero check ([minimum_age] > 0)
)

go
create trigger tgr_box_item_calculate_box_status on item
after insert, update, delete
as
begin
	declare
	@box_changed int,
	@box_maximum_weight float,
	@box_percentage float

	select @box_changed = [box_id] from inserted;
	select @box_maximum_weight = [maximum_weight] from box where id = @box_changed;
	
	if @box_maximum_weight is not null
	begin
			select		@box_percentage = round((sum(item.[weight]) * 100) / box.[maximum_weight], 2)
			from		box
			inner join	item on box.[id] = item.[box_id]
			group by	box.[maximum_weight];

			update box set fullness_percentage = @box_percentage where box.id = @box_changed;
	end;
end;