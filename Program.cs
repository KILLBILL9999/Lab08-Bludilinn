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

string correctPassword = "qwerty123";
int attemptCount = 0;
 
while (true) {
    Console.Write("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine()!;
 
    if (password == correctPassword) {
        Console.WriteLine("Доступ разрешён");
        break;
    }
 
    attemptCount++;
    Console.WriteLine("Неверный пароль, попробуйте снова");
}
 
Console.WriteLine($"Количество неудачных попыток: {attemptCount}");
 