SELECT TOP(3) player_id, AS first_login
FROM Activity
GROUP BY player_id