SELECT DISTINCT A.IDProductos, B.Titulo, A.CantidadVendida
FROM dbo.Ventas AS A
INNER JOIN dbo.Productos AS B
ON A.IDProductos = B.IDProductos
WHERE A.CantidadVendida > 100
ORDER BY A.CantidadVendida DESC;