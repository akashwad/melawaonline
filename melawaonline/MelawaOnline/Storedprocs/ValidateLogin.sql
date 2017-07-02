alter procedure ValidateLogin
@userID varchar(20),
@password varchar(20),
@isValid int output
as 

select count(*) from Login
 where phone_number = @userID and user_password = @password

 set @isValid = (select count(*) from Login
 where phone_number = @userID and user_password = @password)


go

declare @isValid varchar(20)
execute ValidateLogin '5516897283','akashwad', @isValid output
select @isvalid