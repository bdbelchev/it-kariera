-- 1
USE gringotts;

SELECT 
    deposit_group, MAX(magic_wand_size) longest_magic_wand
FROM
    wizzard_deposits
GROUP BY deposit_group
ORDER BY longest_magic_wand , deposit_group;

-- 2
SELECT 
    deposit_group
FROM
    wizzard_deposits
GROUP BY deposit_group
ORDER BY AVG(magic_wand_size)
LIMIT 1;

-- 3
SELECT 
    deposit_group, SUM(deposit_amount) total_sum
FROM
    wizzard_deposits
GROUP BY deposit_group
ORDER BY total_sum;