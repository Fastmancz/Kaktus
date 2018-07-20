<?php
$contents = file_get_contents("https://www.mujkaktus.cz/chces-pridat");
$search   = date('j. n. Y');
$version  = "1.0.1";

if (strpos($contents, $search))
{
	$json_data->kaktus_dobijecka = "1";
	$json_data->kaktus_version = $version;
	$json_get_data = json_encode($json_data, JSON_PRETTY_PRINT);
	echo "$json_get_data";
}
else
{
	$json_data->kaktus_dobijecka = "0";
	$json_data->kaktus_version = $version;
	$json_get_data = json_encode($json_data, JSON_PRETTY_PRINT);
	echo "$json_get_data";
}
?>