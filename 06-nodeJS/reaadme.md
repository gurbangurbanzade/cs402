SELECT _ FROM telebeinfo;
ALTER TABLE telebeinfo
ADD FOREIGN KEY (cityid) REFERENCES cityinfo(cityid);
select _ from telebeinfo
where PersonID!=1
select \* from telebeinfo;

SELECT telebeinfo.personid,telebeinfo.LastName, cityinfo.cityname ,cityinfo.cityid
FROM telebeinfo
LEFT JOIN cityinfo ON cityinfo.cityid = telebeinfo.cityid;
SELECT \* FROM cityinfo;

ALTER TABLE cityinfo
ADD kod int;

ALTER TABLE cityinfo
ADD PRIMARY KEY (cityid);
