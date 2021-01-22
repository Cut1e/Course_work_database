create table Cycle (id_cycle int not null primary key identity(1,1) ,
title_of_cycle varchar(300) not null,
id_teacher int foreign key references Teacher(id_teacher) on delete cascade on update cascade not null);
