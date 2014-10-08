create database DB2288;
use DB2288;
create table users ( username varchar(20), password varchar(40), primary key (username));
insert into users values ( 'admin', sha1('2014CISpass') );

grant select,insert,update,delete on DB2288.* 
             to 'db2288_user'@'localhost' 
             identified by 'db2288_password';
flush privileges;
