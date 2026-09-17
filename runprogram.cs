Student albin = new Student("Albin");
Student maja = new Student("Maja");
Student erik = new Student("Erik");
Student berit = new Student("Berit");
Course matte = new Course("Matte");
matte.MaxSeats = 2;
berit.Leave(matte);// remove utan att programmet crashar
albin.Join(matte);
albin.Join(matte);
maja.Join(matte);
erik.Join(matte); 

matte.Rollcall();// erik tas inte in eftersom det redan finns två personer
albin.Schedule(); // Inga dubbleter albin x2

albin.Leave(matte);
matte.Rollcall();

albin.Leave(matte);
