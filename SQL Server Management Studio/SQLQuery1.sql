Create Database Ornek

Create Table Kullanici_Bilgi(
id int primary key identity (1,1) not null,
kullanici_adi nvarchar(50),
sifre nvarchar(50)

)
insert into Kullanici_Bilgi values ('eagle12','12345')

select *from Kullanici_Bilgi