using LiskovSubstitutionPrinciple.Before;

var adultService = new AdultService();

adultService.Drink();
adultService.PrepareDinner();
adultService.Work();


// Does a baby work or prepare dinner ?

var babyService = new BabyService();
babyService.PrepareDinner();
babyService.Work();