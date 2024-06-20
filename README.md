# CarFilterDatabase
it filters ALL the cars, databasesoft provided the data for the repository 
git Car Filter Database

The program will load data about cars (owner, model, manufacturer, year, color) from a file.
The file can be txt file that looks for example like this:

John Smith; Fiesta; Ford; 2000; green
Peter Johnson; Megane; Renault; 1997; blue

The user can then:

    diplay the whole database

    search for a person, if they have a car, information about the car is shown

    filter cars by parameters
    (for example show only cars of given color, show only cars from given manufacturer)

    filter cars by age
    (for example show only cars that are 5 years old or newer)

    calculate some statistics
    (most favourite model, average age, most favourite colour etc.)

BONUS:

    allow adding / deleting cars from the database, after any changes are made,
    the file is saved / overwritten with the new data
    add new parameters (price, miles per galon) and allow sorting based on these parameters "

make diffirent code for my reposidtory like Car.cs

CarDatabase.cs

MainProgram.cs
ebnf

Odevzdání 72h před zkouškovým termínem – Moodle (kód + dokumentace)
Projekt řeší konkrétní problém
Součástí projektu je dokumentace
    Projekt by měl obsahovat:
    komentáře kódu
    práce se soubory nebo externími dat. zdroji (csv, xml....) 
    bezchybné načítání dat
    bezchybné ukládání dat
    min 3. ošetřené vstupy od uživatele
    menu – volby – funkce
Podrobnosti a konzultace na cvičeních" (claude ai, i need you to write in C#, and nothing else, 

i need you to make a github repository as well and you need to tell me in the end how to set it up,
and it should have a read me and all the other else may be needed for a program, and in the end it should be an exe" the data base will be similar to this but much much loonger <"Make;Model;Annual Petroleum Consumption For Fuel Type1;Annual Petroleum Consumption For Fuel Type2;Time to charge at 120V;Time to charge at 240V;City Mpg For Fuel Type1;Unrounded City Mpg For Fuel Type1 (2);City Mpg For Fuel Type2;Unrounded City Mpg For Fuel Type2;City gasoline consumption;City electricity consumption;EPA city utility factor;Co2 Fuel Type1;Co2 Fuel Type2;Co2 Tailpipe For Fuel Type2;Co2 Tailpipe For Fuel Type1;Combined Mpg For Fuel Type1;Unrounded Combined Mpg For Fuel Type1;Combined Mpg For Fuel Type2;Unrounded Combined Mpg For Fuel Type2;Combined electricity consumption;Combined gasoline consumption;EPA combined utility factor;Cylinders;Engine displacement;Drive;EPA model type index;Engine descriptor;EPA Fuel Economy Score;Annual Fuel Cost For Fuel Type1;Annual Fuel Cost For Fuel Type2;Fuel Type;Fuel Type1;GHG Score;GHG Score Alternative Fuel;Highway Mpg For Fuel Type1;Unrounded Highway Mpg For Fuel Type1;Highway Mpg For Fuel Type2;Unrounded Highway Mpg For Fuel Type2;Highway gasoline consumption;Highway electricity consumption;EPA highway utility factor;Hatchback luggage volume;Hatchback passenger volume;ID;2 door luggage volume;4 door luggage volume;MPG Data;PHEV Blended;2-door passenger volume;4-door passenger volume;Range For Fuel Type1;Range City For Fuel Type1;Range City For Fuel Type2;Range Highway For Fuel Type1;Range Highway For Fuel Type2;Transmission;Unadjusted City Mpg For Fuel Type1;Unadjusted City Mpg For Fuel Type2;Unadjusted Highway Mpg For Fuel Type1;Unadjusted Highway Mpg For Fuel Type2;Vehicle Size Class;Year;You Save/Spend;Guzzler;Transmission descriptor;T Charger;S Charger;ATV Type;Fuel Type2;Epa Range For Fuel Type2;Electric motor;MFR Code;c240Dscr;charge240b;C240B Dscr;Created On;Modified On;Start-Stop;PHEV City;PHEV Highway;PHEV Combined;baseModel
Chevrolet;Celebrity Wagon;14.883125;0.0;0.0;0.0;21;0.0;0;0.0;0.0;0.0;0.0;-1;-1;0.0;424.1666666666667;24;0.0;0;0.0;0.0;0.0;0.0;6;4.3;;4322;DIESEL CA model;;2350;0;Diesel;Diesel;;;29;0.0;0;0.0;0.0;0.0;0.0;0;0;28182;0;42;N;false;0;98;0;0.0;0.0;0.0;0.0;Automatic 3-spd;26.0;0.0;41.0;0.0;Midsize Station Wagons;1984;-2250;;;;;;;;;;;0.0;;2013-01-01;2013-01-01;;0;0;0;Celebrity
Mazda;B2000/B2200 Pickup 2WD;12.935217391304349;0.0;0.0;0.0;21;0.0;0;0.0;0.0;0.0;0.0;-1;-1;0.0;386.39130434782606;23;0.0;0;0.0;0.0;0.0;0.0;4;2.0;2-Wheel Drive;56085;CALIF CA model;;2350;0;Regular;Regular Gasoline;;;26;0.0;0;0.0;0.0;0.0;0.0;0;0;28270;0;0;N;false;0;0;0;0.0;0.0;0.0;0.0;Manual 5-spd;26.0;0.0;36.0;0.0;Small Pickup Trucks 2WD;1984;-2250;;;;;;;;;;;0.0;;2013-01-01;2013-01-01;;0;0;0;B Pickup
Chevrolet;C10 Pickup 2WD;18.799736842105265;0.0;0.0;0.0;17;0.0;0;0.0;0.0;0.0;0.0;-1;-1;0.0;535.7894736842105;19;0.0;0;0.0;0.0;0.0;0.0;8;6.2;2-Wheel Drive;4885;DIESEL CA model;;2950;0;Diesel;Diesel;;;22;0.0;0;0.0;0.0;0.0;0.0;0;0;28297;0;0;N;false;0;0;0;0.0;0.0;0.0;0.0;Automatic 4-spd;21.0;0.0;30.0;0.0;Standard Pickup Trucks 2WD;1984;-5250;;;;;Diesel;;;;;;0.0;;2013-01-01;2013-01-01;;0;0;0;C10 Pickup
GMC;C25 Pickup 2WD;18.799736842105265;0.0;0.0;0.0;17;0.0;0;0.0;0.0;0.0;0.0;-1;-1;0.0;535.7894736842105;19;0.0;0;0.0;0.0;0.0;0.0;8;6.2;2-Wheel Drive;4885;DIESEL CA model;;2950;0;Diesel;Diesel;;;22;0.0;0;0.0;0.0;0.0;0.0;0;0;28333;0;0;N;false;0;0;0;0.0;0.0;0.0;0.0;Automatic 4-spd;21.0;0.0;30.0;0.0;Standard Pickup Trucks 2WD;1984;-5250;;;;;Diesel;;;;;;0.0;;2013-01-01;2013-01-01;;0;0;0;Pickup

"> check the copy pasted data csv phile to write the code for the repository and dont make it half finished make the code work perfectly with no rooms for improvment