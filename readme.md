[checkbox-img]: https://raw.githubusercontent.com/gardient/Gardient.ConsoleUtils/master/Assets/Screenshots/checkbox.png
[confirm-img]: https://raw.githubusercontent.com/gardient/Gardient.ConsoleUtils/master/Assets/Screenshots/confirm.PNG
[extended-img]: https://raw.githubusercontent.com/gardient/Gardient.ConsoleUtils/master/Assets/Screenshots/extended.png
[input-img]: https://raw.githubusercontent.com/gardient/Gardient.ConsoleUtils/master/Assets/Screenshots/input.png
[list-img]: https://raw.githubusercontent.com/gardient/Gardient.ConsoleUtils/master/Assets/Screenshots/list.png
[password-img]: https://raw.githubusercontent.com/gardient/Gardient.ConsoleUtils/master/Assets/Screenshots/password.PNG
[rawlist-img]: https://raw.githubusercontent.com/gardient/Gardient.ConsoleUtils/master/Assets/Screenshots/rawlist.png

[![.NET](https://github.com/gardient/Gardient.ConsoleUtils/actions/workflows/dotnet.yml/badge.svg)](https://github.com/gardient/Gardient.ConsoleUtils/actions/workflows/dotnet.yml)

I would say this was inspired by [agolaszewski's Inquierer.cs](https://github.com/agolaszewski/Inquirer.cs) but that would imply that I didn't just copy most of the code

At this point all I did was:

- [x] Break it into different projects
- [x] Move it to netstandard2.0
- [ ] Change the way the Inquirer.Prompt works so that it's more in line with inquirer.js

Really if you want a well maintained package you should check out [their repository](https://github.com/agolaszewski/Inquirer.cs)

Without further ado here is the rest of the original README

Inquirer.cs
===========

A collection of common interactive command line user interfaces.

Clone of [Inquirer.js](https://github.com/SBoudrias/Inquirer.js)

## Installation

```shell
Install-Package Inquirer.cs
```

## Prompt types

#### List

```csharp
List<ConsoleColor> colors = Enum.GetValues(typeof(ConsoleColor)).Cast<ConsoleColor>().ToList();
Question.List("Choose favourite color", colors);
```
![][list-img]

#### Raw List
```csharp
List<ConsoleColor> colors = Enum.GetValues(typeof(ConsoleColor)).Cast<ConsoleColor>().ToList();
Question.RawList("Choose favourite color", colors);
```
![][rawlist-img]

#### Expand
```csharp
var colors = new Dictionary<ConsoleKey, ConsoleColor>();
            colors.Add(ConsoleKey.B, ConsoleColor.Blue);
            colors.Add(ConsoleKey.C, ConsoleColor.Cyan);
            colors.Add(ConsoleKey.D, ConsoleColor.DarkBlue);

Question.ExtendedList("Choose favourite color", colors);
```
![][extended-img]

#### Checkbox
```csharp
var colors = Enum.GetValues(typeof(ConsoleColor)).Cast<ConsoleColor>().ToList();
Question.Checkbox("Choose favourite colors", colors);
```
![][checkbox-img]

#### Confirm
```csharp
Question.Confirm("Are you sure?");
```
![][confirm-img]

#### Input
```csharp
Question.Input("How are you?");
Question.Input<int>("2+2")
```
![][input-img]

#### Password
```csharp
Question.Password("Type password");
```
![][password-img]

#### Menu

```csharp
private static void MenuTest()
        {
            Question.Menu("Choose")
               .AddOption("PagingCheckboxTest", () => { PagingCheckboxTest(); })
               .AddOption("PagingRawListTest", () => { PagingRawListTest(); })
               .AddOption("PagingListTest", () => { PagingListTest(); })
               .AddOption("InputTest", () => { InputTest(); })
               .AddOption("PasswordTest", () => { PasswordTest(); })
               .AddOption("ListTest", () => { ListTest(); })
               .AddOption("ListRawTest", () => { ListRawTest(); })
               .AddOption("ListCheckboxTest", () => { ListCheckboxTest(); })
               .AddOption("ListExtendedTest", () => { ListExtendedTest(); })
               .AddOption("ConfirmTest", () => { ConfirmTest(); }).Prompt();
        }
```

## Extensions

Change the number of lines that will be rendered when using list, rawList, or checkbox.
```csharp
.Page(int pageSize)
```

Default value(s) to use if nothing is entered.
```csharp
.WithDefaultValue(...)
args:
TResult defaultValue
List<TResult> defaultValues : for list types and types implementing IComparable
Func<TResult, bool> compareTo : for list types not implementing IComparable

```
Chosen value displayed for final confirmation

For password type, user have to confirm password by typing it again

```csharp
.WithConfirmation()
```

Set display name for complex type
```csharp
.WithConvertToString(Func<TResult, string> fn)
```

Should return true if the value is valid, and an error message (String) otherwise. If false is returned, a default error message is provided.

```csharp
.WithValidation(Func<TResult, bool> fn, string errorMessage)
.WithValidation(Func<TResult, bool> fn, Func<TResult, string> errorMessageFn)
```

## Inquirer

```csharp
_test = new Inquirer();
```
Inquirer is for preserving history
It supports 
- navigation
- optional prompts
- hierarchical prompts


```csharp
string answer = string.Empty;
Inquirer.Prompt(Question.Input("1")).Bind(() => answer);
Inquirer.Prompt(Question.Input("2")).Bind(() => answer);
Inquirer.Prompt(() =>
{
    if (answer.Length > 5)
    {
        return Question.Input("3");
    }

    return null;
}).Then(answer2 =>
{
    Inquirer.Prompt(Question.Input("3.1")).Bind(() => answer);
    Inquirer.Prompt(Question.Input("3.2")).Bind(() => answer);
    Inquirer.Prompt(Question.Input("3.3")).Bind(() => answer);
});
Inquirer.Go();
```
