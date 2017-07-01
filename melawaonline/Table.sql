create table Login
(phone_number varchar(20), user_password varchar(20), unique_id varchar(10))

select * from login

create table user_profile (unique_id varchar(10), firstname varchar(20),middlename varchar(20),gender varchar(10), familyname varchar(20),
dateofbirth date, birthtime timestamp,birthplace varchar(20))
create table user_address (unique_id varchar(10), addressline1 varchar(max),addressline2 varchar(max),
city varchar(20), state varchar(20), pincode varchar(20),country varchar(20))
create table user_education_occupation
(unique_id varchar(10), graduation_status varchar(20),college varchar(20), college_city varchar(20), college_state varchar(20),
special_qualification  varchar(20))
create table user_preferences(unique_id varchar(10),match_edu varchar(10), match_req varchar(max),match_age_range varchar(20))
