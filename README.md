# dpu

db.ciofuwpvxhep.ap-southeast-1.rds.amazonaws.com<br />

port 1433<br />

username: sa<br />

password: Aa123456<br />

ติดตั้ง dotnet tool ผ่าน Terminal ใน VS Code<br/>
dotnet tool install --global dotnet-ef <br/>

Scaffold command<br/>
dotnet ef dbcontext Scaffold "Server=db.ciofuwpvxhep.ap-southeast-1.rds.amazonaws.com,1433;Initial Catalog=surasak;User ID=sa;Password=Aa123456;" Microsoft.EntityFrameworkCore.SqlServer --schema "dbo" --data-annotations -c DbContext
