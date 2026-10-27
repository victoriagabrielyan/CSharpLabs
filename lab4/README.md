**Լաբ 4.  using in, out, ref, params, and parameters by default values**

## Խնդրի դրվածքը

* Ստեղծել static A(), B(), C() մեթոդները, համապատասխանաբար in, out, ref, մոդֆիկատորները փորձարկելու համար  
    * Ստեղծել նաև SumValues(parasm … ) մեթոդը որը կգումարի մուտքում եկած ամբողջ թվերը, թվերի քանակը ֆիքսված չէ
    * ցույց տալ թե ինչպես են աշխատում այս մեթոդները, Main() մեթոդում
   
## Կատարած առաջադրանքը

Կոդը՝ [Methods.cs](Methods.cs) և [Program.cs](Program.cs)

Ծրագրի ելքը՝

```
A(in): x = 26
B(out): x = 222
Main: b = 222
C(ref): initial x = 18
Main: c = 36
SumValues(5, 12, 44) = 61
```