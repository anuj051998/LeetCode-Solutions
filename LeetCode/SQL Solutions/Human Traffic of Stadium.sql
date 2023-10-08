SELECT id
	,visit_date
    ,people
FROM (
	SELECT id
		,people
		,visit_date
		,COUNT(IslandId) OVER (
			PARTITION BY IslandId ORDER BY IslandId
			) AS cnt
	FROM (
		SELECT *
			,CASE 
				WHEN id - Groups.PreviousID > 1
					THEN 1
				ELSE 0
				END AS IslandStartInd
			,SUM(CASE 
					WHEN id - Groups.PreviousID > 1
						THEN 1
					ELSE 0
					END) OVER (
				ORDER BY Groups.RN
				) AS IslandId
		FROM (
			SELECT ROW_NUMBER() OVER (
					ORDER BY id
					) AS RN
				,id
				,people
				,visit_date
				,LAG(id, 1, - 1) OVER (
					ORDER BY id
					) AS PreviousID
			FROM stadium
			WHERE people >= 100
			) Groups
		) t1
	) t2
WHERE t2.cnt >= 3
ORDER BY visit_date 