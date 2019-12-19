--判断数据库是否存在
if exists (select * from sysdatabases where name='Student')
drop database Student
go

--创建数据库
create database Student
go

--切换数据库
use Student
go
--判断职位表是否存在
if exists(select * from sys.tables where name='Position')
drop table Position
go
--职位表
create table Position
(
	Pid int identity(1,1) primary key,--职位ID
	PName varchar(50) not null,--职位名称
)
--添加职位信息
insert into Position values('教务主任')
insert into Position values('老师')
insert into Position values('学生')
go


--判断专业表是否存在
if exists(select * from sys.tables where name='Major')
drop table Major
go
--创建专业表
create table Major
(
	MajorID  int primary key identity(1,1),			--专业编号
	MajorName varchar(50) not null					--专业名称
)
insert into Major values('计算机应用技术')
insert into Major values('物联网技术')
insert into Major values('大数据应用')
insert into Major values('企业信息化')
insert into Major values('移动开发')
insert into Major values('软件技术')
go
---判断学生信息表是否存在
if exists(select * from sys.tables where name='StudentInfo')
drop table StudentInfo
go
--创建学生信息表
create table StudentInfo
(
	StudentID int primary key identity(190901,1),			--学生编号
	StudentName varchar(50) not null,						--学生姓名
	StudentSex varchar(2) not null,							--学生性别
	StudentAge int  not null,								--学生年龄
	StudentPhone varchar(50) not null,						--学生电话	
	MajorID int references Major(MajorID),					--所学专业
	Score int,												--成绩
	Pid int references Position(Pid)						--身份/1，主任2，教师3,学生				
)

--添加表信息
insert into StudentInfo values('刘大','男',15,'13525109532',1,99,3);
insert into StudentInfo values('陈二','女',17,'13525109530',2,56,3);
insert into StudentInfo values('张三','男',18,'13525109533',3,45,3);
insert into StudentInfo values('李四','男',12,'13525102222',4,88,3);
insert into StudentInfo values('王五','女',23,'13525103333',5,79,3);
insert into StudentInfo values('卫六','男',25,'13525105555',6,45,3);

insert into StudentInfo values('陈伟霆','男',15,'13525109532',1,73,3);
insert into StudentInfo values('张艺兴','男',18,'13525109533',2,62,3);
insert into StudentInfo values('阚清子','女',17,'13525109530',3,85,3);
insert into StudentInfo values('霍建华','男',12,'13525102222',4,60,3);
insert into StudentInfo values('林心如','女',23,'13525103333',5,81,3);
insert into StudentInfo values('罗志祥','男',25,'13525105555',6,92,3);

insert into StudentInfo values('杨幂','男',15,'13525109532',1,63,3);
insert into StudentInfo values('刘源','男',18,'13525109533',2,99,3);
insert into StudentInfo values('刘涛','女',17,'13525109530',3,74,3);
insert into StudentInfo values('杨玏','男',12,'13525102222',4,89,3);
insert into StudentInfo values('王珂','女',23,'13525103333',5,51,3);
insert into StudentInfo values('陈赫','男',25,'13525105555',6,69,3);

insert into StudentInfo values('陈主任','男',25,'13525101919',null,null,1);
insert into StudentInfo values('王老师','女',25,'13525102020',null,null,2);
insert into StudentInfo values('刘老师','男',25,'13525102121',null,null,2);
insert into StudentInfo values('李老师','女',25,'13525102222',null,null,2);
go

--判断登录表是否存在
if exists(select * from sys.tables where name='Record')
drop table Record
go
--创建登录表
create table Record
(
	RecordID int identity(1,1) primary key,						--登录id
	StudentID int references StudentInfo(StudentID) not null,	--登录名
	RecordPassword varchar(20) not null,						--登录密码
	Pid int references Position(Pid)							--身份/1，主任2，教师3,学生
)
--添加登录信息
insert into Record values(190901,'1234',3)
insert into Record values(190920,'1234',2)
insert into Record values(190921,'1234',2)
insert into Record values(190922,'1234',2)
insert into Record values(190919,'1234',1)
go

--查询职位信息表
select * from Position
--查询专业表
select * from Major
--查询学生信息表
select * from StudentInfo
--查询登录表信息
select * from Record
------登录
--if exists(select * from sys.procedures where name='YLogin')
--drop proc YLogin
--go
--create proc YLogin  @StudentID int,@RecordPassword int
--as
	
--go
--exec YLogin


--select * from Record where RecordID='' and RecordPassword=''