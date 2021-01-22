create table Composition(id_composition int not null primary key identity(1,1) ,
id_teacher int foreign key references Teacher(id_teacher) not null,
id_cycle int foreign key references Cycle(id_cycle)on delete cascade on update cascade not null);
