create table Teacher(id_teacher int not null primary key identity(1,1) ,
FIO_teatcher varchar(300) not null,
date_of_start_working date,
id_cabinets int foreign key references Cabinets(id_cabinets)on delete cascade on update cascade);
