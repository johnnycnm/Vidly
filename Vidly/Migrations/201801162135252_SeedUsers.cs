namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'95b7f65b-131f-43c9-9f20-c1c9716dffb5', N'admin@vidly.com', 0, N'ANz7PGdPoq0x1ElLAuP7t1cln9yB647LXVbfmsh7JTPp9e1c6e7nHB2SIrKjoM03ig==', N'8ecec259-a406-44c3-b025-8116f76b11d7', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a6e0cb6c-b840-4f6c-8d96-f41c2fd62316', N'guest@vidly.com', 0, N'AMcpDCffj9B2C7yfEPPmJn90iKS2EEn7WYU1R/CSTK2pqFdHzhqULYW0O1oYFEW02Q==', N'effa3759-ac78-450c-a29f-92b6f96c8b40', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f5d142d1-809c-4789-9c37-f01503b5d7c9', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'95b7f65b-131f-43c9-9f20-c1c9716dffb5', N'f5d142d1-809c-4789-9c37-f01503b5d7c9')



            ");
        }
        
        public override void Down()
        {
        }
    }
}
