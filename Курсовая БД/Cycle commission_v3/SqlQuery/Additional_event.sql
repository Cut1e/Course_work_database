create table Additional_event(id_additional_event int not null primary key identity(1,1) ,
title_of_additional_event varchar(300) not null,
course varchar(100)not null,
number_of_students int not null,
id_teacher int foreign key references Teacher(id_teacher)on delete cascade on update cascade);
