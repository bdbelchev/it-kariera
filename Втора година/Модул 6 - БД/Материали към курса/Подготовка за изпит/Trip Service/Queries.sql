-- 1
SELECT id, name
FROM cities
WHERE country_code = 'BG'
ORDER BY name ASC;

-- 2
SELECT CONCAT_WS(' ', first_name, middle_name, last_name) AS 'Full Name', YEAR(birth_date) AS BirthYear
FROM accounts
WHERE YEAR(birth_date) > 1991
ORDER BY YEAR(birth_date) DESC, first_name;

-- 3
SELECT c.name AS City, COUNT(h.id) AS Hotels
FROM cities c
LEFT OUTER JOIN hotels h ON h.city_id = c.id
GROUP BY c.name
ORDER BY Hotels DESC, c.name;

-- 4 
SELECT r.id AS Id, r.price AS Price, h.name AS Hotel, c.name AS City
FROM rooms r
JOIN hotels h ON r.hotel_id = h.id
JOIN cities c ON h.city_id = c.id
WHERE r.type = 'First Class'
ORDER BY r.price DESC, r.id;

-- 5 JOIN ORDER BY CONCAT MIN MAX GROUP BY
SELECT a.id AS AccountId, 
	concat_ws(' ', a.first_name, a.last_name) AS FullName,
    MAX(DATEDIFF(t.return_date, t.arrival_date)) AS LongestTrip,
    MIN(DATEDIFF(t.return_date, t.arrival_date)) AS ShortestTrip
FROM accounts a
JOIN accounts_trips at ON at.account_id = a.id
JOIN trips t ON t.id = at.trip_id
WHERE t.cancel_date IS NULL AND a.middle_name IS NULL
GROUP BY a.id
ORDER BY LongestTrip DESC, a.id;

-- 6 LIMIT JOIN COUNT() GROUP BY ORDER
SELECT c.id AS Id, c.name AS City, c.country_code AS Country, COUNT(a.id) AS Accounts
FROM  cities c
JOIN accounts a ON a.city_id = c.id
GROUP BY c.id
ORDER BY Accounts DESC, c.id
LIMIT 5;

-- 7 JOIN ORDER BY GROUP BY COUNT()
SELECT a.id AS Id, a.email AS Email, c.name AS City, COUNT(t.id) AS Trips
FROM accounts a 
JOIN accounts_trips at ON a.id = at.account_id
JOIN trips t ON t.id = at.trip_id
JOIN rooms r ON r.id = t.room_id
JOIN hotels h ON h.id = r.hotel_id
JOIN cities c ON c.id = h.city_id
WHERE a.city_id = c.id
GROUP BY a.id
HAVING Trips > 0
ORDER BY Trips DESC, a.id;














