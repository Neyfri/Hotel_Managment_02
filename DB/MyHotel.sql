CREATE DATABASE myHotel

use myHotel

CREATE TABLE rooms(
idRoom int Identity(1,1) primary key,
noRooom varchar(250) not null unique,
roomType varchar(250) not null,
bed varchar(250) not null,
price bigint not null,
booked varchar(50) default 'NO'
);


insert into rooms (noRooom, roomType, bed, price, booked) values('100','AC','triple',11000,'YES'),('101','AC','Double',8000,'NO'),('221','AC','Single',5000,'NO')

select * from rooms

CREATE TABLE customer(
cid int Identity(1,1) primary key,
cname varchar(250) not null unique,
mobile bigint not null,
nationality varchar(250) not null,
gender varchar(50) not null,
dob varchar(250) not null,
idproof varchar(250) not null,
adress varchar(250) not null,
checkin varchar(250) not null,
checkout varchar(250) not null,
chekout varchar(250) not null default 'NO',
room_id int not null,
foreign key (room_id) references rooms(idRoom)
);

select * from customer

CREATE TABLE employee(
eid int IDENTITY(1,1) PRIMARY KEY,
ename VARCHAR(250) NOT NULL,
mobile BIGINT NOT NULL,
gender VARCHAR(50) NOT NULL,
emailid VARCHAR(120) NOT NULL,
username VARCHAR(150) NOT NULL,
pass VARCHAR(150) NOT NULL
);

select * from employee

INSERT INTO employee(ename, mobile, gender, emailid, username, pass) VALUES('Kristy',18093233212,'Female','kristy29@hotmail.com','kristy29','enter');