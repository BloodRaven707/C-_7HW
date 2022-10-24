# Команды для терминала

## С# Создание и запуск приложения

- dotnet new console
- dotnet run

## GIT Создание и выгрузка на сервер GitHub локального репозитория

- git init
- git add .
- git commit -m "Initial commit"
- git remote add origin https://github.com/BloodRaven707/<название_репозитория>.git
- git branch -M main
- git push -u origin main

<br>

# Заметки

## Описание функции C# 

- ``/// <summary>Описание функции</summary>``
- ``/// <param name="имя_переменной">Описание аргумента</param>``
- ``/// <returns>Описание вывода</returns>``

<br>

## Шаблон C# для Program.cs

```
namespace Console_Program
{
    class Project
    {
        /// <summary>Описание функции</summary>
        /// <param name="имя_переменной">Описание аргумента</param>
        /// <returns>Описание вывода</returns>

        private static void Main( string[] args ) {
            // Описание программы
        }
    }
}
```

<br>


## Шаблон C# для .gitignore

```
### Языки программирования
# C#
[Bb][Ii][Nn]/
[Oo][Bb][Jj]/


### Среда разработки
# VS Code
.vscode/

# Microsoft Visual Studio
.vs/
```

<br>

<br>

<br>

# Проверки ввода

```
/// <summary>Выводит сообщение в консоль, проверяет и преобразует пользовательский ввод.</summary>
/// <param name="message">Выводимое в консоль сообщение</param>
/// <returns>Число типа Int32</returns>

static public int ConsoleInputInt32( string message="Введите целое число: " ) {
    int result = 0; 

    while ( true ) {
        Console.Write( message );

        if ( int.TryParse( Console.ReadLine() ?? "", out result ) )
            break;

        Console.WriteLine( "[!] Вы ввели не верные данные!\n" );
    }
    return result; 
}


/// <returns>Число типа Double</returns>
static public double ConsoleInputDouble( string message="Введите вещественное число: " ) {
    double result = 0; 

    while ( true ) {
        Console.Write( message );

        if ( double.TryParse( Console.ReadLine() ?? "", out result ) )
            break;

        Console.WriteLine( "[!] Вы ввели не верные данные!\n" );
    }
    return result; 
}
```