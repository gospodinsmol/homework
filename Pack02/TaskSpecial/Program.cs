// Пользователь вводит объем флешки в Гб, вычислить сколько на флешку поместится фильмов по 760мб, 
//музыкальных клипов пр 95 мб, аудиозаписей по 7 мб и текстовых документов по 350кб
//приоритеты фильмы-клипы-ауди-доки

Console.WriteLine("Объем флешки в Гб:");
int val = int.Parse(Console.ReadLine());
int valMb = val*1024;
int movie = valMb/760;
int clips = (valMb - movie * 760) / 95;
int audio = (valMb - movie * 760 - clips * 95) / 7;
int textDoc = (valMb - movie * 760 - clips * 95 - audio * 7) * 1024 / 350;
Console.WriteLine($"флешка {val} вместит: {movie} фильмов {clips} клипов и {audio} аудио и {textDoc} текстовых документов");