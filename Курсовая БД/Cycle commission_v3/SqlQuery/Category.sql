create table Category(id_category int not null primary key identity(1,1) ,
title_of_category varchar(200) not null,
date_of_assignment date,
place_of_assigment varchar(300),
id_teacher int foreign key references Teacher(id_teacher)on delete cascade on update cascade);
