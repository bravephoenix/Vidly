namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4e3fdf05-a7fb-4bf3-912e-e67bddd6a0c9', N'guest@vidly.com', 0, N'AL2XP1dCv2r9r4OZj9BoLVVhafdripfns49CbwuXjgcuwrK2G4hgbgRfTdOG/le1RQ==', N'c2c81482-f396-4035-85ae-ab9d010009ad', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9f222248-7397-4774-94cc-0153abd0ba92', N'admin@gmail.com', 0, N'AGUDZvUIlfMCrFdvtsWLmWDLp1dJvVdq5VWBLSPqoqsX2xLre5ovU3Pji1Nr6T+B+w==', N'6cbcd209-32f7-4b2b-ad6b-b0b2ae78d0b5', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6a4a7d41-b9e6-4e79-b16e-c21f399ed351', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9f222248-7397-4774-94cc-0153abd0ba92', N'6a4a7d41-b9e6-4e79-b16e-c21f399ed351')


            ");
        }
        
        public override void Down()
        {
        }
    }
}
