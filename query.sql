/*
В базе данных MS SQL Server есть продукты и категории.
Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов.
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». 
Если у продукта нет категорий, то его имя все равно должно выводиться.
*/
Select p."Name" as "Продукты" , c."Name" as "Категории"
from Products p
LEFT JOIN ProductCategories pc on p.Id = pc.ProductId
LEFT JOIN Categories c on pc.CategoryId = c.Id
