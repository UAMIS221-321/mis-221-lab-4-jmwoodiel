// start main
int userChoice = GetUserChoice(); // priming read
// pre-test loop
while(userChoice!=3) { // condition check
    RouteEm(userChoice);
    userChoice = GetUserChoice(); // update read
}
// end main

// methods

static int GetUserChoice() {
    DisplayMenu();
    string userChoice=Console.ReadLine();
    if(IsValidChoice(userChoice)) {
        return int.Parse(userChoice);
    }
   else return 0;
}

static void DisplayMenu() {
   Console.Clear();
    System.Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit");
}

static bool IsValidChoice(string userInput) {
    if(userInput=="1" || userInput=="2" || userInput=="3") {
        return true;
    }
    else return false;
}

static void GetFull() {
    DisplayFull();
    PauseAction();
}

static void GetPartial() {
    DisplayPartial();
    PauseAction();
}

static void SayInvalid() {
    System.Console.WriteLine("Invalid!");
    PauseAction();
}

static void RouteEm(int menuChoice) {
    if(menuChoice==1) {
        GetFull();
    }
    else if(menuChoice==2) {
        GetPartial();
    }
    else if (menuChoice!=3) {
        SayInvalid();
}}

static void PauseAction() {
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

static void DisplayFull() {
    int numRows = GetRandomNumRows(3, 10);
    PrintTriangle(numRows);
}

static int GetRandomNumRows(int min, int max) {
    Random rnd = new Random();
    return rnd.Next(min, max + 1);
}

static void PrintTriangle(int numRows) {
    for (int i = 1; i <= numRows; i++) {
        for (int j = 0; j < i; j++) {
            Console.Write("o");
        }
        Console.WriteLine();
    }
}

static void DisplayPartial() {
    Random rnd = new Random();
    int numRows = rnd.Next(3, 10);    
    GenerateTriangle(numRows, rnd);
    }

static void GenerateTriangle(int numRows, Random rnd) {
    for (int i = 1; i <= numRows; i++) {
        GenerateRow(i, rnd);
        Console.WriteLine();
    }
}

static void GenerateRow(int rowNumber, Random rnd) {
    for (int j = 0; j < rowNumber; j++) {
        if (rnd.Next(0, 2) == 0) {
            Console.Write(" ");
        } else {
            Console.Write("o");
    }
    }
}