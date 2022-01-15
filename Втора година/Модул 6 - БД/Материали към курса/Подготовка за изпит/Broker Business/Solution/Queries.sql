-- 1
SELECT id, username, company_id 
FROM persons
WHERE city_id = 10 AND company_id IS NOT NULL
ORDER BY username ASC, id ASC;

-- 2
SELECT id, name as building_name, rent_amount, height, status 
FROM buildings
WHERE rent_amount > 5000 AND height > 500
ORDER BY rent_amount DESC, building_name ASC;

-- 3
SELECT p.id, p.username, pi.first_name, pi.last_name, c.name 
FROM persons p
JOIN companies c ON c.id = p.company_id
JOIN person_info pi ON pi.person_id = p.id
WHERE c.name = 'West'
ORDER BY first_name, last_name;

-- 4
SELECT p.username, c.name as company_name, cc.name as city_name, cc.country_name
FROM persons p
LEFT JOIN companies c ON p.company_id = c.id
JOIN cities cc ON p.city_id= cc.id
WHERE p.id <= 15
ORDER BY company_id, username;

-- 5
SELECT bt.name as building_type, 
	COUNT(b.id) buildings_count, 
	MAX(b.rent_amount) max_rent, 
	MIN(b.rent_amount) min_rent
FROM buildings b
JOIN building_types bt ON b.type_id = bt.id
GROUP BY bt.id
ORDER BY buildings_count DESC;

-- 6
SELECT 
	b.name as building_name, 
    bt.name as building_type,
    b.status,
    c.name as city_name,
    COUNT(p.id) persons_count
FROM buildings b
JOIN building_types bt ON b.type_id = bt.id
JOIN cities c ON b.city_id = c.id
JOIN persons_buildings pb ON pb.building_id = b.id
JOIN persons p ON p.id = pb.person_id
GROUP BY b.id
ORDER BY persons_count DESC
LIMIT 50;

-- 7
SELECT 
	cc.name as company_name,
    b.status,
    SUM(b.rent_amount) sum,
    COUNT(b.id) buildings_count
FROM buildings b
JOIN building_types bt ON b.type_id = bt.id
JOIN cities c ON b.city_id = c.id
JOIN companies cc ON cc.id = b.company_id
GROUP BY cc.id, b.status
HAVING sum > 150000
ORDER BY sum DESC, buildings_count DESC;