
-- Insertar Vendedor
Insert into vendor(vendor.name,vendor.surname,vendor.vendor_code)values('Juan','Perez','001JP');
-- Insertar Productos

Insert into product(name) values('Camisa');  --1
Insert into product(name) values('Pantalon'); --2

-- Insertar Tipo de Producto

Insert into producttype(name) values('Manga Corta'); -- 1
Insert into producttype(name) values('Cuello Mao'); -- 2
Insert into producttype(name) values('Chupin'); --3 
Insert into producttype(name) values('Cuello común'); --4
Insert into producttype(name) values('Manga Larga'); -- 5
Insert into producttype(name) values('común'); -- 6

-- insertar Calidad

Insert into quality(name) values('Standar'); -- 1
Insert into quality(name) values('Preimum'); --2


-- insertar stock

-- Manga corta y Cuello mao - Standar y premium
Insert into detail_stock(product_id, producttype_id, producttype2_id, quality_id,qty,priceunit)
values(1,1,2,1,100,5)
;
Insert into detail_stock(product_id, producttype_id,producttype2_id, quality_id,qty,priceunit)
values(1,1,2,2,100,15)
;
-- Manga corta y comun - Standar y premium
Insert into detail_stock(product_id, producttype_id,producttype2_id, quality_id,qty,priceunit)
values(1,1,4,1,150,4)
;

Insert into detail_stock(product_id, producttype_id,producttype2_id, quality_id,qty,priceunit)
values(1,1,4,2,150,14)
;

-- Manga Larga

Insert into detail_stock(product_id, producttype_id,producttype2_id, quality_id,qty,priceunit)
values(1,5,2,1,75,7)
;

Insert into detail_stock(product_id, producttype_id,producttype2_id, quality_id,qty,priceunit)
values(1,5,2,2,75,17)
;

Insert into detail_stock(product_id, producttype_id,producttype2_id, quality_id,qty,priceunit)
values(1,5,4,1,175,8)
;

Insert into detail_stock(product_id, producttype_id,producttype2_id, quality_id,qty,priceunit)
values(1,5,4,2,175,18)
;

-- Pantalones

Insert into detail_stock(product_id, producttype_id,producttype2_id, quality_id,qty,priceunit)
values(2,3,null,1,750,9)
;

Insert into detail_stock(product_id, producttype_id,producttype2_id, quality_id,qty,priceunit)
values(2,3,null,2,750,9)
;

Insert into detail_stock(product_id, producttype_id,producttype2_id, quality_id,qty,priceunit)
values(2,6,null,1,250,9)
;

Insert into detail_stock(product_id, producttype_id,producttype2_id, quality_id,qty,priceunit)
values(2,6,null,2,250,9)
;
