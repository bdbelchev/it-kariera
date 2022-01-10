-- 1
USE gringotts;

SELECT 
    deposit_group,
    magic_wand_creator,
    MIN(deposit_charge) min_deposit_charge
FROM
    wizzard_deposits
GROUP BY magic_wand_creator , deposit_group
ORDER BY magic_wand_creator , deposit_group;

-- 2
SELECT 
    CASE
        WHEN age BETWEEN 0 AND 10 THEN '[0-10]'
        WHEN age BETWEEN 11 AND 20 THEN '[11-20]'
        WHEN age BETWEEN 21 AND 30 THEN '[21-30]'
        WHEN age BETWEEN 31 AND 40 THEN '[31-40]'
        WHEN age BETWEEN 41 AND 50 THEN '[41-50]'
        WHEN age BETWEEN 51 AND 60 THEN '[51-60]'
        WHEN age >= 61 THEN '[61+]'
    END age_group,
    COUNT(id) wizard_count
FROM
    wizzard_deposits
GROUP BY age_group
ORDER BY wizard_count;

-- 3
SELECT 
    MID(first_name, 1, 1) first_letter
FROM
    wizzard_deposits
GROUP BY first_letter
ORDER BY first_letter;

-- 4
SELECT 
    deposit_group,
    is_deposit_expired,
    AVG(deposit_interest) average_interest
FROM
    wizzard_deposits
WHERE
    deposit_start_date > '1985-01-01'
GROUP BY deposit_group
ORDER BY deposit_group DESC , deposit_expiration_date ASC;