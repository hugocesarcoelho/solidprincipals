using LiskovSubstitutionPrinciple.Before;

var adultService = new AdultService();

adultService.Drink();
adultService.PrepareDinner();
adultService.Work();


// Now, the baby cannot work or prepare dinner anymore!

var babyService = new BabyService();
babyService.Drink();
babyService.Listen();