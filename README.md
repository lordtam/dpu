# dpu

db.ciofuwpvxhep.ap-southeast-1.rds.amazonaws.com<br />

port 1433<br />

username: sa<br />

password: Aa123456<br />

<br/>
======================================================================================
<br/>

dotnet new webapi<br/>

dotnet watch run<br/>

ติดตั้ง dotnet tool ผ่าน Terminal ใน VS Code<br/>
dotnet tool install --global dotnet-ef <br/>

Scaffold command<br/>
dotnet ef dbcontext Scaffold "Server=db.ciofuwpvxhep.ap-southeast-1.rds.amazonaws.com,1433;Initial Catalog=surasak;User ID=sa;Password=Aa123456;" Microsoft.EntityFrameworkCore.SqlServer -o Entities --data-annotations -c DatabaseContext

<br/>
https://support.google.com/chrome/answer/95417?hl=en&co=GENIE.Platform%3DDesktop#zippy=%2Cwindows

<br/>
==========================
<br/>
USE [surasak];<br/>
GO<br/>
<br/>
CREATE OR ALTER PROCEDURE [dbo].[GetProductById]<br/>
	@id int<br/>
AS<br/>
   SET NOCOUNT ON;<br/>
<br/>
   SELECT *  <br/>
   FROM Product AS sp  <br/>
   WHERE Id = @id;<br/>
   <br/>
   RETURN;<br/>
GO <br/>

USE [surasak]<br/>
GO<br/>

DECLARE	@return_value int<br/>
EXEC [dbo].[GetProductById] @id = 1<br/>
GO


<br/>

=====

dotnet watch run --launch-profile=development
