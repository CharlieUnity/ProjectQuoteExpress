/****** Script for SelectTopNRows command from SSMS  ******/
select  * from producttype


delete from product where product_id > 2
-- Revisión Producto

SELECT 
pd.name as producto
,(select ptt.name from producttype ptt where ptt.producttype_id = dt.producttype_id) as tipo1
,(select ptt2.name from producttype ptt2 where ptt2.producttype_id = dt.producttype2_id) as tipo2
,(select qa.name from quality qa where qa.quality_id = dt.quality_id) as calidad
,dt.qty as cantidad_disponible
--,dt.priceunit as precio
FROM detail_stock dt
join product pd on pd.product_id = dt.product_id  ;

-- Total Productos
SELECT 
pd.name as producto
,sum(dt.qty) as cantidad_disponible
--,dt.priceunit as precio
FROM detail_stock dt
join product pd on pd.product_id = dt.product_id  
group by pd.name

-- historial vendedor

select 
vendor
,datequote
,product
,type1
,type2
,quality
,qtyquote
,priceunit
,totalquote
from quotehistory_v
where vendor_code='001JP'

