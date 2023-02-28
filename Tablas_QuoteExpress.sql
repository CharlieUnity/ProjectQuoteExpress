CREATE TABLE vendor(
   vendor_id INT PRIMARY KEY IDENTITY(1,1),
   name NVARCHAR(50) ,
   surname NVARCHAR(50) ,
   vendor_code NVARCHAR(10) NOT NULL
);

CREATE TABLE product(
   product_id INT PRIMARY KEY IDENTITY(1,1),
   name NVARCHAR(50) ,
);

--  drop table producttype;
CREATE TABLE producttype(
   producttype_id INT PRIMARY KEY IDENTITY(1,1),
   name NVARCHAR(50) ,
);

CREATE TABLE quality(
   quality_id INT PRIMARY KEY IDENTITY(1,1),
   name NVARCHAR(50) ,
);

-- drop table detail_stock;
CREATE TABLE detail_stock(
   detail_stock_id INT PRIMARY KEY IDENTITY(1,1),
   product_id int,
   producttype_id int,
   producttype2_id int,
   quality_id int,
   qty int,
   priceunit numeric(12,5)
);

ALTER TABLE detail_stock
ADD CONSTRAINT dts_product_fk FOREIGN KEY (product_id)
REFERENCES product (product_id);

ALTER TABLE detail_stock
ADD CONSTRAINT dts_producttype_fk FOREIGN KEY (producttype_id)
REFERENCES producttype (producttype_id);

ALTER TABLE detail_stock
ADD CONSTRAINT dts_producttype2_fk FOREIGN KEY (producttype2_id)
REFERENCES producttype (producttype_id);

ALTER TABLE detail_stock
ADD CONSTRAINT dts_quality_fk FOREIGN KEY (quality_id)
REFERENCES quality (quality_id);


--  drop table quote_history;
CREATE TABLE quote_history(
   quote_history_id INT PRIMARY KEY IDENTITY(1,1),
   vendor_id int,
   product_id int,
   producttype_id int,
   producttype2_id int,
   quality_id int,
   qty int,
   priceunit numeric(12,5),
   totalprice numeric(12,5),
   datequote datetime
);

ALTER TABLE quote_history
ADD CONSTRAINT qh_vendor_fk FOREIGN KEY (vendor_id)
REFERENCES vendor(vendor_id);

ALTER TABLE quote_history
ADD CONSTRAINT qh_product_fk FOREIGN KEY (product_id)
REFERENCES product (product_id);

ALTER TABLE quote_history
ADD CONSTRAINT qh_producttype_fk FOREIGN KEY (producttype_id)
REFERENCES producttype (producttype_id);

ALTER TABLE quote_history
ADD CONSTRAINT qh_producttype2_fk FOREIGN KEY (producttype2_id)
REFERENCES producttype (producttype_id);

ALTER TABLE quote_history
ADD CONSTRAINT qh_qa_fk FOREIGN KEY (quality_id)
REFERENCES quality (quality_id);

-- Vista Historia
-- drop view quotehistory_v
create view quotehistory_v
as
SELECT 
v.vendor_code 
,v.name + ' ' + v.surname  as vendor
,dt.datequote as datequote
,pd.name as product
,(select ptt.name from producttype ptt where ptt.producttype_id = dt.producttype_id) as type1
,(select ptt2.name from producttype ptt2 where ptt2.producttype_id = dt.producttype2_id) as type2
,(select qa.name from quality qa where qa.quality_id = dt.quality_id) as quality
,dt.qty as qtyquote
,dt.priceunit as priceunit
,dt.totalprice as totalquote
FROM quote_history dt
join product pd on pd.product_id = dt.product_id 
join vendor v on v.vendor_id = dt.vendor_id
;
