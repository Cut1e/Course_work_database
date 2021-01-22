create table goals(id_goals int not null primary key identity(1,1) ,
title_of_goals varchar(30) not null,
goals_description varchar(100),
id_years int foreign key references Years(id_years)on delete cascade on update cascade);
