namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                        FullName = c.String(),
                        Gender = c.String(),
                        BirthOfDate = c.String(),
                        PlaceOfBirth = c.String(),
                        EmailAddress = c.String(),
                        IdentityCard = c.String(),
                        DateOfIssueOfIidentificationCard = c.String(),
                        PlaceOfIssuanceOfIdentityCard = c.String(),
                        PhoneNumber = c.String(),
                        HomeNumber = c.String(),
                        Address = c.String(),
                        IndustryOrFaculty = c.String(),
                        CourseEnrollment = c.String(),
                        SystemTraining = c.String(),
                        Worker = c.String(),
                        Farmer = c.String(),
                        OfficersAndEmployees = c.String(),
                        ClassOrSocietyHasExperienced = c.String(),
                        Achievement = c.String(),
                        Gifted = c.String(),
                        SummaryOfLearningProcess = c.String(),
                        CommendationOrDiscipline = c.String(),
                        Religion = c.String(),
                        Nation = c.String(),
                        RoadNameOrHamlet = c.String(),
                        WardOrCommuneOrTown = c.String(),
                        ProvinceOrCity = c.String(),
                        DistrictOrDistrictOrTown = c.String(),
                        FullNameOccupationPlaceOfSibling = c.String(),
                        MotherFullName = c.String(),
                        FatherFullName = c.String(),
                        MotherJob = c.String(),
                        FatherJob = c.String(),
                        MotherPhoneNumber = c.String(),
                        FatherPhoneNumber = c.String(),
                        MotherCitizenship = c.String(),
                        FatherCitizenship = c.String(),
                        MotherNation = c.String(),
                        FatherNation = c.String(),
                        MotherReligion = c.String(),
                        FatherReligion = c.String(),
                        MotherPermanentResidence = c.String(),
                        FatherPermanentResidence = c.String(),
                        MotherBirthOfDate = c.String(),
                        FatherBirthOfDate = c.String(),
                        DateCreate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
