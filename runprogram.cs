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
erik.Schedule(); // tom, erik nekades

albin.Leave(matte);
matte.Rollcall();

albin.Leave(matte);

matte.Enroll(erik);
matte.Rollcall();
erik.Schedule();

matte.Enroll(berit); // kursen är full här så berit nekas att enrollas
berit.Schedule();

matte.Remove(erik);
matte.Rollcall();
erik.Schedule();

matte.Remove(berit); // berit finns inte och inget crashar

Console.WriteLine(maja);
Console.WriteLine(erik);
Console.WriteLine(matte);
