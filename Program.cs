// int lessonNumber = 5;
 
// while (lessonNumber >= 1) {
//     Console.WriteLine($"Пара {lessonNumber}");
//     lessonNumber--;
// }
 
// Console.WriteLine("Пары закончились");
 

//  int count = 0;
 
// Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine()!);
 
// while (grade != -1) {
//     Console.WriteLine($"Оценка принята: {grade}");
//     count++;
//     grade = int.Parse(Console.ReadLine()!);
// }
 
// Console.WriteLine("Ввод завершён");
// Console.WriteLine($"Количество введённых оценок: {count}");
 

// N-3
// int sum = 0;
// int count = 0;
// int maxGrade = int.MinValue;
 
// Console.WriteLine("Вводите оценки, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine()!);
 
// while (grade != -1) {
//     sum += grade;
//     count++;
//     if (grade > maxGrade) {
//         maxGrade = grade;
//     }
//     grade = int.Parse(Console.ReadLine()!);
// }
 
// if (count > 0) {
//     Console.WriteLine($"Средний балл: {(double)sum / count:F2}");
//     Console.WriteLine($"Наибольшая оценка: {maxGrade}");
// } else {
//     Console.WriteLine("Оценок не было введено");
// }
 

// N-4

// string correctPassword = "qwerty123";
// int attemptCount = 0;
 
// while (true) {
//     Console.Write("Введите пароль от личного кабинета: ");
//     string password = Console.ReadLine()!;
 
//     if (password == correctPassword) {
//         Console.WriteLine("Доступ разрешён");
//         break;
//     }
 
//     attemptCount++;
//     Console.WriteLine("Неверный пароль, попробуйте снова");
// }
 
// Console.WriteLine($"Количество неудачных попыток: {attemptCount}");
 


// string answer;
 
// do {
//     Console.Write("Введите дату посещения (например, 01.09): ");
//     string date = Console.ReadLine()!;
//     Console.WriteLine($"Запись добавлена: {date}");
 
//     Console.Write("Добавить ещё одну запись? (да/нет): ");
//     answer = Console.ReadLine()!;
// } while (answer == "да");
 
// Console.WriteLine("Дневник сохранён");
 

// b
// int count = 0;
 
// Console.WriteLine("Вводите имена учеников. Для завершения введите 'конец':");
// string name = Console.ReadLine()!;
 
// while (name != "конец") {
//     count++;
//     name = Console.ReadLine()!;
// }
 
// Console.WriteLine($"Всего введено имён: {count}");
 

//  v
// int totalPages = 0;
 
// Console.WriteLine("Вводите количество страниц, прочитанных за день. Для завершения введите -1:");
// int pages = int.Parse(Console.ReadLine()!);
 
// while (pages != -1) {
//     totalPages += pages;
//     pages = int.Parse(Console.ReadLine()!);
// }
 
// Console.WriteLine($"Всего прочитано страниц: {totalPages}");
 
// variant
// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");
 

// N-5
string correctCode = "4821";
 
while (true) {
    Console.Write("Введите код домофона: ");
    string code = Console.ReadLine()!;
 
    if (code == correctCode) {
        Console.WriteLine("Дверь открыта");
        break;
    }
 
    Console.WriteLine("Неверный код, попробуйте снова");
}
 

// N-8
// string correctPassword = "qwerty123";
// int attempts = 0;
// bool accessGranted = false;
 
// while (attempts < 3 && !accessGranted) {
//     Console.Write("Введите пароль: ");
//     string password = Console.ReadLine()!;
 
//     if (password == correctPassword) {
//         accessGranted = true;
//     } else {
//         attempts++;
//         if (attempts < 3) {
//             Console.WriteLine($"Неверный пароль. Осталось попыток: {3 - attempts}");
//         }
//     }
// }
 
// if (accessGranted) {
//     Console.WriteLine("Доступ разрешён");
// } else {
//     Console.WriteLine("Доступ заблокирован");
// }
 