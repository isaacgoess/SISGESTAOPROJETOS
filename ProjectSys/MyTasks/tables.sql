create table Users
( Id        int identity primary key,
  Email     varchar(50) unique,
  Password  varchar(10) not null,
  JoinedOn  datetime
);

insert into Users values('macoratti@yahoo.com','a',getdate());


create table  Projects
(  Id        int identity(100,1) primary key,
   Title     varchar(100) not null,
   CreatedOn datetime,
   UserId    int  references Users(Id) on delete cascade
);

insert into Projects values('Tarefas.Net',getdate(), 1);
insert into Projects values('Livros',getdate(), 1);

create table  Tasks
(  Id          int identity(1000,1) primary key,
   Title       varchar(100) not null,
   AddedOn     datetime,
   DueDate     datetime,
   Importance  char(1),     /*  b, n, u */   /* b-aixa    n-ormal    u-rgente  */
   [Status]      char(1),   /*  i, a, c */   /* i-niciar  a-ndamento c-oncluida  */
   
   ProjectId   int  references Projects(Id) on delete cascade
);


insert into tasks values('Pagina Login',getdate(), '15/4/15','n','y',100);
insert into tasks values('Prepara material para aula',getdate(), '11/5/15','l','p',101);





