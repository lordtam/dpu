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
dotnet ef dbcontext Scaffold "Server=db.ciofuwpvxhep.ap-southeast-1.rds.amazonaws.com,1433;Initial Catalog=surasak;User ID=sa;Password=Aa123456;" Microsoft.EntityFrameworkCore.SqlServer --schema "dbo" --data-annotations -c DbContext

<br/>
https://support.google.com/chrome/answer/95417?hl=en&co=GENIE.Platform%3DDesktop#zippy=%2Cwindows

<br/>
<PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="6.0.8">
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
      <PrivateAssets>all</PrivateAssets>
</PackageReference><br/>
<PackageReference Include="Microsoft.EntityFrameworkCore.Relational" Version="6.0.8" /><br/>
<PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="6.0.8" /><br/>
