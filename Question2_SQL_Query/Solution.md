Предположим, что мы имеем три разные таблицы, которые описывают категории и их свойтсва:
| CategoryID | CategoryName |
| -- | -- |
| f2be5497-6101-4d1c-8dee-6e33b3c2fc1f | Category1 |
| caead148-8451-424f-9996-90a92950be96 | Category2 |
| 3d883277-c386-4464-9da4-790726ea5431 | Category3 |

Таблицу продуктов и их свойства:
| ProductID | ProductName |
| -- | -- |
| 6b9c3785-c113-4946-b34b-e02fe6c01716 | Product1 |
| 4b5cf50a-8f77-4a29-88cf-d1453e7814c1 | Product2 |
| dd2e370f-cb46-46c9-b1d5-6e4ed54ffa4e | Product3 |

И таблицу для связи по типу "многие ко многим":
| ProductID | CategoryID |
| 6b9c3785-c113-4946-b34b-e02fe6c01716 | caead148-8451-424f-9996-90a92950be96 |

Тогда, при условии, что в двух разных таблицах могут содержаться данные запроса для получения всех видов пар может выглядеть следующим образом:

```sql
SELECT DISTINCT Products.ProductName, Categories.CategoryName 
FROM Products
LEFT JOIN ProductsCategories ON Products.ProductID = ProductsCategories.ProductID
LEFT JOIN Categories ON ProductsCategories.CategoryID = Categories.CategoryID
LIMIT 1000
```