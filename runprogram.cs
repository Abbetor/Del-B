Student albin = new Student("Albin");
Student maja = new Student("Maja");
Student erik = new Student("Erik");

Course matte = new Course("Matte");
matte.MaxSeats = 2;

albin.Join(matte);
albin.Join(matte);
maja.Join(matte);
erik.Join(matte);

matte.Rollcall();
albin.Schedule();

albin.Leave(matte);
matte.Rollcall();

albin.Leave(matte);
