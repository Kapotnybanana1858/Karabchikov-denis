<br>Структура Функции :
<br>1. тип данных у функции и аргументов 
<br>2. имя функции и аргументов
<br>Виды типов данных :
<br>простые и сложные 
<br>приимер простого типа :
<br>string int 
<br>пример сложного типа :
<br>List
<br>String[]
<br>public - индетинфикатор доступа, переводится как публичный, все программы видят данные, 
<br>Функция может быть обьявлена и содержать код в {}, а может быть вызвана в Main, в {} обязательно есть return если тип данных не вводят, возвращаем мы переменную с тем же типом данных что и функция. Для вызова функции мы убираем тип данных и переносим их: тип данных функции в тип данных переменной которою хотим сохранить результат, а тип данных аргументов в переменные с данными которые мы хотим передать в функцию
```
List<Mark> GetMarks (DateTime now, List<string> students) 
{
list<Mark> res;
return res;
}
тип данных:List<Mark>, DateTime, List<string> имя: GetMarks, now, students
DateTime now;
List<string> students;
List<Mark> a = GetMarks (now, students);


double MinAVG(string [] marks)
{
double res;
return res;
}
тип данных:double, string[] имя: MinAVG, marks
string[] marks;
double a = MinAVG (marks);


int[] GetCountTruancy(List<Mark> marks)
{
int[] res;
return res;
}
тип данных:int[], List<Mark> имя: GetCountTruancy, marks
List<Mark> marks;
int[] a = GetCountTruancy (marks);



int[] GetCountDisease (List<Mark> marks)
{
int[] res;
return res;
}
тип данных:int[], List<Mark> имя: GetCountDisease, marks
List<Mark> marks;
int[] a = GetCountDisease (marks);



string GetStudNumber (int year, int group, string fio),
{
string res;
return res;
}
тип данных:string, int имя: GetStudNumber, year, group, fio
int year;
int group;
string fio;
string a = GetStudNumber (year, group, fio);
```
Класс - как только появилось слово класс мы перешли к ООП это значит что мы стараемся подогнать любой элемент под какой-то шаблон, и характеристики этого элемента добавить в класс. Характеристики = свойства = переменные. Чтобы использовать этот шаблон нам нужно создавать экземляры(конкретные объекты) к примеру: для общего класса student мы можем создать экземпляр student1, шаблон создания элемента:
``` 
тип данных_имя объекта = new тип данных()
 string[] student = new string[]()
 Имя класса_Экземпляр = new имя класса()
 Student Student1 = new Student()
 Mark mark = new Mark()
 mark.date = 02.03.2002
 mark.progul = "б"
 Console.WriteLine(mark.date, mark.progul);
  



