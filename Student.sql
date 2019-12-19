--�ж����ݿ��Ƿ����
if exists (select * from sysdatabases where name='Student')
drop database Student
go

--�������ݿ�
create database Student
go

--�л����ݿ�
use Student
go
--�ж�ְλ���Ƿ����
if exists(select * from sys.tables where name='Position')
drop table Position
go
--ְλ��
create table Position
(
	Pid int identity(1,1) primary key,--ְλID
	PName varchar(50) not null,--ְλ����
)
--���ְλ��Ϣ
insert into Position values('��������')
insert into Position values('��ʦ')
insert into Position values('ѧ��')
go


--�ж�רҵ���Ƿ����
if exists(select * from sys.tables where name='Major')
drop table Major
go
--����רҵ��
create table Major
(
	MajorID  int primary key identity(1,1),			--רҵ���
	MajorName varchar(50) not null					--רҵ����
)
insert into Major values('�����Ӧ�ü���')
insert into Major values('����������')
insert into Major values('������Ӧ��')
insert into Major values('��ҵ��Ϣ��')
insert into Major values('�ƶ�����')
insert into Major values('�������')
go
---�ж�ѧ����Ϣ���Ƿ����
if exists(select * from sys.tables where name='StudentInfo')
drop table StudentInfo
go
--����ѧ����Ϣ��
create table StudentInfo
(
	StudentID int primary key identity(190901,1),			--ѧ�����
	StudentName varchar(50) not null,						--ѧ������
	StudentSex varchar(2) not null,							--ѧ���Ա�
	StudentAge int  not null,								--ѧ������
	StudentPhone varchar(50) not null,						--ѧ���绰	
	MajorID int references Major(MajorID),					--��ѧרҵ
	Score int,												--�ɼ�
	Pid int references Position(Pid)						--���/1������2����ʦ3,ѧ��				
)

--��ӱ���Ϣ
insert into StudentInfo values('����','��',15,'13525109532',1,99,3);
insert into StudentInfo values('�¶�','Ů',17,'13525109530',2,56,3);
insert into StudentInfo values('����','��',18,'13525109533',3,45,3);
insert into StudentInfo values('����','��',12,'13525102222',4,88,3);
insert into StudentInfo values('����','Ů',23,'13525103333',5,79,3);
insert into StudentInfo values('����','��',25,'13525105555',6,45,3);

insert into StudentInfo values('��ΰ��','��',15,'13525109532',1,73,3);
insert into StudentInfo values('������','��',18,'13525109533',2,62,3);
insert into StudentInfo values('������','Ů',17,'13525109530',3,85,3);
insert into StudentInfo values('������','��',12,'13525102222',4,60,3);
insert into StudentInfo values('������','Ů',23,'13525103333',5,81,3);
insert into StudentInfo values('��־��','��',25,'13525105555',6,92,3);

insert into StudentInfo values('����','��',15,'13525109532',1,63,3);
insert into StudentInfo values('��Դ','��',18,'13525109533',2,99,3);
insert into StudentInfo values('����','Ů',17,'13525109530',3,74,3);
insert into StudentInfo values('��W','��',12,'13525102222',4,89,3);
insert into StudentInfo values('����','Ů',23,'13525103333',5,51,3);
insert into StudentInfo values('�º�','��',25,'13525105555',6,69,3);

insert into StudentInfo values('������','��',25,'13525101919',null,null,1);
insert into StudentInfo values('����ʦ','Ů',25,'13525102020',null,null,2);
insert into StudentInfo values('����ʦ','��',25,'13525102121',null,null,2);
insert into StudentInfo values('����ʦ','Ů',25,'13525102222',null,null,2);
go

--�жϵ�¼���Ƿ����
if exists(select * from sys.tables where name='Record')
drop table Record
go
--������¼��
create table Record
(
	RecordID int identity(1,1) primary key,						--��¼id
	StudentID int references StudentInfo(StudentID) not null,	--��¼��
	RecordPassword varchar(20) not null,						--��¼����
	Pid int references Position(Pid)							--���/1������2����ʦ3,ѧ��
)
--��ӵ�¼��Ϣ
insert into Record values(190901,'1234',3)
insert into Record values(190920,'1234',2)
insert into Record values(190921,'1234',2)
insert into Record values(190922,'1234',2)
insert into Record values(190919,'1234',1)
go

--��ѯְλ��Ϣ��
select * from Position
--��ѯרҵ��
select * from Major
--��ѯѧ����Ϣ��
select * from StudentInfo
--��ѯ��¼����Ϣ
select * from Record
------��¼
--if exists(select * from sys.procedures where name='YLogin')
--drop proc YLogin
--go
--create proc YLogin  @StudentID int,@RecordPassword int
--as
	
--go
--exec YLogin


--select * from Record where RecordID='' and RecordPassword=''