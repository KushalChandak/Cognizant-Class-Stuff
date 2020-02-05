create database ORG;
use ORG;

create table worker(worker_id int not null primary key identity(1,1), first_name char(25), last_name char(20),salary money ,joining_date datetime,department char(20));

insert into worker(first_name, last_name ,salary, joining_date, department) 
values('devyani','patidar','18000','2014-05-02','ACCOUNT');
		
select * from worker;
select * from bonus;

create table bonus(worker_ref_id int, bonus_amount int,bonus_date datetime );

insert into bonus (worker_ref_id,bonus_amount,bonus_date)values(002,3500,'2015-08-11');

alter table bonus 
drop table bonus; 

create table title(worker_ref_id int, worker_title char(25),affected_from datetime);

insert into title (worker_ref_id,worker_title,affected_from) values (002,'executive','2016-06-11'),
																	(008,'executive','2016-06-11'),
																	(005,'manager','2016-06-11'),
																	(004,'asst.manager','2016-06-11'),
																	(007,'executive','2016-06-11'),
																	(006,'lead','2016-06-11'),
																	(003,'lead','2016-06-11');

select * from title;


select * from worker;
select first_name as worker_name from worker;
select upper(first_name) from worker;
select distinct department from worker;
select substring(first_name,1,3) from worker;
select rtrim(first_name) from worker;
select distinct count(department ) from worker;
select * from worker where first_name like '%a%'




