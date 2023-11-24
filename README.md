Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

## Решение

При решении задачи был использован класс **ArrayMaster**, содержащий в себе статические методы работы с массивами:

### Метод NewArrayStringsNoLongerThan

Метод принимает на вход массив и целое число (прописано в Program.cs в начале как константа),
указывающее на количество символов для сравнения длинн значений. Возвращает новый массив, образованный
выбором только тех значений из входного массива, количество символов которых меньше либо равно указанной константе.

К решению прилагается **блок-схема** работы алгоритма:

![Блок-схема работы алгоритма](https://lh3.googleusercontent.com/pw/ADCreHcxg6PF3UHMPETj1b_S1tE5n_YL4NimOrNJ3Dv6Z6GOijMjQ0GH3R8gMayBGrAk-rGs34LMW-mVkEkGaFsx50MflnomY7fnnq7kfLxmo8PkF-1JEV0BkCZMdjC9QfMV_Fu4kglwkRNzUksm0zG8OGEXOgTc8_Cq1ZYkUXnmqwtWYa6SVmIIezrPJmRhJOEslVaIVkvb5dcedusF_YhvHPNdRp-Iz7XoHaH47aArgqpU7cfXDr1z57GJSybIuVG-RtzKKtJIrtO2c4KihUU5RV3Fh-_-E-ofJ7a-kHXElH8ukI4GcN1P-CKS1NW8FpkyUEj3S351dIJvYT8RLTZT3OUhEGiM-zChCfCzYw_mBuwGsEEuFKbIqTfaiwCXlkMLX1k1bP_Vax6WOnkQja82r_nQGADuDcJr2VcNMTgtnj6T3Qj6sGXo7tvwiVVGt0zZ3sCrAe5OoqpRyE8RFpjX5HzDTk_PYHsk5b939R2gS4Qv0NldvZ2tf3TP0ufmH8t2EO30pDdgVyU4FkHh41SuYbfKre7bRykPqODimGe-98t9mCQemNwZqINnGFUhzAz7hWrnjPejmnGoIC0zXUJrs6i2sLnZm2_nBuEyWJKjoc-UwOIfqG6K5jDrbwlnfNZQmAi_l70hfmRCZCPmEdeMn4Ciyv0P6AIcOisFK9x3HdbMVW_Q6U-5yPLTvmrKWSbX7ulZAE5GKMozmI4uqBFrkk4s1vmCrTK_3-3DEAleNOo6i1sVRF-nVORytn2PcGWH2k3Mt4WqQgXy7XAAdmfiHFIZQNyUjA4WL2JCwBFq6I42CsiEBRkxyiy2Kqf9bJE6hdk3-tpxCLcY671rZ0lH13LofYOAFbnt3N7rYarKKLE2Va_8WWkNmzrEzZYYHao3jV_Scek=w692-h619-s-no-gm?authuser=0)

### Метод PrintArray

Метод принимает на вход массив и строковое значение - *message*.
Применяется для вывода массива и сообщения пользователю в терминал.
В методе используется **string.Join** для сцепления элементов массива с указанным разделителем между ними.

### Файл Program.cs
содержит основной код программы:
- константа - количество символов для сравнения;
- сообщение пользователю;
- примеры массивов из задачи;
- использование методов;
- предложение пользователю задать собственный массив для проверки работы программы.

### Файл ArrayMaster.cs
содержит класс ArrayMaster, являющийся основным методом решения задачи.
