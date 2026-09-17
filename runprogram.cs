Student albin = new Student("Albin");
Course matte = new Course("Matte");
Course programmering = new Course("Programmering");

albin.Join(matte);
albin.Join(programmering);
albin.Schedule();
matte.Rollcall();
programmering.Rollcall();




