namespace Kazi.Interfaces.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bugs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ReproSteps = c.String(),
                        SystemInfo = c.String(),
                        AcceptanceCriteria = c.String(),
                        State = c.String(),
                        Priority = c.Int(nullable: false),
                        Estimate = c.Int(nullable: false),
                        BusinessValue = c.String(),
                        ValueArea = c.String(),
                        Area = c.String(),
                        Iteration = c.String(),
                        AssignedTo_Id = c.Int(),
                        Epic_Id = c.Int(),
                        Feature_Id = c.Int(),
                        UserStory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.AssignedTo_Id)
                .ForeignKey("dbo.Epics", t => t.Epic_Id)
                .ForeignKey("dbo.Features", t => t.Feature_Id)
                .ForeignKey("dbo.UserStories", t => t.UserStory_Id)
                .Index(t => t.AssignedTo_Id)
                .Index(t => t.Epic_Id)
                .Index(t => t.Feature_Id)
                .Index(t => t.UserStory_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        LastLogedIn = c.DateTime(nullable: false),
                        Created = c.DateTime(nullable: false),
                        AssignedTo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.AssignedTo_Id)
                .Index(t => t.AssignedTo_Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Epics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        AcceptanceCriteria = c.String(),
                        State = c.String(),
                        Priority = c.Int(nullable: false),
                        Estimate = c.Int(nullable: false),
                        BusinessValue = c.String(),
                        ValueArea = c.String(),
                        Area = c.String(),
                        Iteration = c.String(),
                        AssignedTo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.AssignedTo_Id)
                .Index(t => t.AssignedTo_Id);
            
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        AcceptanceCriteria = c.String(),
                        State = c.String(),
                        Priority = c.Int(nullable: false),
                        Estimate = c.Int(nullable: false),
                        BusinessValue = c.String(),
                        ValueArea = c.String(),
                        Area = c.String(),
                        Iteration = c.String(),
                        AssignedTo_Id = c.Int(),
                        Epic_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.AssignedTo_Id)
                .ForeignKey("dbo.Epics", t => t.Epic_Id)
                .Index(t => t.AssignedTo_Id)
                .Index(t => t.Epic_Id);
            
            CreateTable(
                "dbo.Impediments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Resolution = c.String(),
                        State = c.String(),
                        Priority = c.Int(nullable: false),
                        Area = c.String(),
                        Iteration = c.String(),
                        AssignedTo_Id = c.Int(),
                        BugParent_Id = c.Int(),
                        Epic_Id = c.Int(),
                        Feature_Id = c.Int(),
                        UserStory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.AssignedTo_Id)
                .ForeignKey("dbo.Bugs", t => t.BugParent_Id)
                .ForeignKey("dbo.Epics", t => t.Epic_Id)
                .ForeignKey("dbo.Features", t => t.Feature_Id)
                .ForeignKey("dbo.UserStories", t => t.UserStory_Id)
                .Index(t => t.AssignedTo_Id)
                .Index(t => t.BugParent_Id)
                .Index(t => t.Epic_Id)
                .Index(t => t.Feature_Id)
                .Index(t => t.UserStory_Id);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        State = c.String(),
                        Priority = c.Int(nullable: false),
                        Area = c.String(),
                        Iteration = c.String(),
                        Blocked = c.Boolean(nullable: false),
                        RemainingWork = c.Int(nullable: false),
                        BugParent_Id = c.Int(),
                        Epic_Id = c.Int(),
                        Feature_Id = c.Int(),
                        UserStory_Id = c.Int(),
                        Impediment_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bugs", t => t.BugParent_Id)
                .ForeignKey("dbo.Epics", t => t.Epic_Id)
                .ForeignKey("dbo.Features", t => t.Feature_Id)
                .ForeignKey("dbo.UserStories", t => t.UserStory_Id)
                .ForeignKey("dbo.Impediments", t => t.Impediment_Id)
                .Index(t => t.BugParent_Id)
                .Index(t => t.Epic_Id)
                .Index(t => t.Feature_Id)
                .Index(t => t.UserStory_Id)
                .Index(t => t.Impediment_Id);
            
            CreateTable(
                "dbo.UserStories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        AcceptanceCriteria = c.String(),
                        State = c.String(),
                        Priority = c.Int(nullable: false),
                        Estimate = c.Int(nullable: false),
                        BusinessValue = c.String(),
                        ValueArea = c.String(),
                        Area = c.String(),
                        Iteration = c.String(),
                        EpicParent_Id = c.Int(),
                        FeatureParent_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Epics", t => t.EpicParent_Id)
                .ForeignKey("dbo.Features", t => t.FeatureParent_Id)
                .Index(t => t.EpicParent_Id)
                .Index(t => t.FeatureParent_Id);
            
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        AssignedTo_Id = c.Int(),
                        UserRole_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.AssignedTo_Id)
                .ForeignKey("dbo.UserRoles", t => t.UserRole_Id)
                .Index(t => t.AssignedTo_Id)
                .Index(t => t.UserRole_Id);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TeamUsers",
                c => new
                    {
                        Team_Id = c.Int(nullable: false),
                        User_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Team_Id, t.User_Id })
                .ForeignKey("dbo.Teams", t => t.Team_Id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.Team_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Permissions", "UserRole_Id", "dbo.UserRoles");
            DropForeignKey("dbo.Permissions", "AssignedTo_Id", "dbo.Users");
            DropForeignKey("dbo.Tasks", "Impediment_Id", "dbo.Impediments");
            DropForeignKey("dbo.Tasks", "UserStory_Id", "dbo.UserStories");
            DropForeignKey("dbo.Impediments", "UserStory_Id", "dbo.UserStories");
            DropForeignKey("dbo.UserStories", "FeatureParent_Id", "dbo.Features");
            DropForeignKey("dbo.UserStories", "EpicParent_Id", "dbo.Epics");
            DropForeignKey("dbo.Bugs", "UserStory_Id", "dbo.UserStories");
            DropForeignKey("dbo.Tasks", "Feature_Id", "dbo.Features");
            DropForeignKey("dbo.Tasks", "Epic_Id", "dbo.Epics");
            DropForeignKey("dbo.Tasks", "BugParent_Id", "dbo.Bugs");
            DropForeignKey("dbo.Impediments", "Feature_Id", "dbo.Features");
            DropForeignKey("dbo.Impediments", "Epic_Id", "dbo.Epics");
            DropForeignKey("dbo.Impediments", "BugParent_Id", "dbo.Bugs");
            DropForeignKey("dbo.Impediments", "AssignedTo_Id", "dbo.Users");
            DropForeignKey("dbo.Features", "Epic_Id", "dbo.Epics");
            DropForeignKey("dbo.Bugs", "Feature_Id", "dbo.Features");
            DropForeignKey("dbo.Features", "AssignedTo_Id", "dbo.Users");
            DropForeignKey("dbo.Bugs", "Epic_Id", "dbo.Epics");
            DropForeignKey("dbo.Epics", "AssignedTo_Id", "dbo.Users");
            DropForeignKey("dbo.Bugs", "AssignedTo_Id", "dbo.Users");
            DropForeignKey("dbo.TeamUsers", "User_Id", "dbo.Users");
            DropForeignKey("dbo.TeamUsers", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.Users", "AssignedTo_Id", "dbo.Users");
            DropIndex("dbo.TeamUsers", new[] { "User_Id" });
            DropIndex("dbo.TeamUsers", new[] { "Team_Id" });
            DropIndex("dbo.Permissions", new[] { "UserRole_Id" });
            DropIndex("dbo.Permissions", new[] { "AssignedTo_Id" });
            DropIndex("dbo.UserStories", new[] { "FeatureParent_Id" });
            DropIndex("dbo.UserStories", new[] { "EpicParent_Id" });
            DropIndex("dbo.Tasks", new[] { "Impediment_Id" });
            DropIndex("dbo.Tasks", new[] { "UserStory_Id" });
            DropIndex("dbo.Tasks", new[] { "Feature_Id" });
            DropIndex("dbo.Tasks", new[] { "Epic_Id" });
            DropIndex("dbo.Tasks", new[] { "BugParent_Id" });
            DropIndex("dbo.Impediments", new[] { "UserStory_Id" });
            DropIndex("dbo.Impediments", new[] { "Feature_Id" });
            DropIndex("dbo.Impediments", new[] { "Epic_Id" });
            DropIndex("dbo.Impediments", new[] { "BugParent_Id" });
            DropIndex("dbo.Impediments", new[] { "AssignedTo_Id" });
            DropIndex("dbo.Features", new[] { "Epic_Id" });
            DropIndex("dbo.Features", new[] { "AssignedTo_Id" });
            DropIndex("dbo.Epics", new[] { "AssignedTo_Id" });
            DropIndex("dbo.Users", new[] { "AssignedTo_Id" });
            DropIndex("dbo.Bugs", new[] { "UserStory_Id" });
            DropIndex("dbo.Bugs", new[] { "Feature_Id" });
            DropIndex("dbo.Bugs", new[] { "Epic_Id" });
            DropIndex("dbo.Bugs", new[] { "AssignedTo_Id" });
            DropTable("dbo.TeamUsers");
            DropTable("dbo.UserRoles");
            DropTable("dbo.Permissions");
            DropTable("dbo.UserStories");
            DropTable("dbo.Tasks");
            DropTable("dbo.Impediments");
            DropTable("dbo.Features");
            DropTable("dbo.Epics");
            DropTable("dbo.Teams");
            DropTable("dbo.Users");
            DropTable("dbo.Bugs");
        }
    }
}
