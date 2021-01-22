create table Responsible(id_responsible int not null primary key identity(1,1) ,
id_event_ int foreign key references Event_(id_event_) not null,
id_teacher int foreign key references Teacher(id_teacher)on delete cascade on update cascade not null);
