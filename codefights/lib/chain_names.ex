defmodule ChainNames do
  def chainNames(names) do
    res = Enum.reduce(names, %{}, fn(name, acc) ->
      put_in_map(Enum.reduce(names, [], fn(tmp_name, acc2) ->
        eval_name(acc2, name, tmp_name)
      end), acc, name)
    end)

    [n3] = MapSet.difference(MapSet.new(Map.keys(res)), MapSet.new(Map.values(res)))
            |> MapSet.to_list

    {l, _} = Enum.reduce(1..length(names), {[], n3}, fn(_, {list, cur}) ->
      {list ++ [cur], Map.get(res, cur)}
    end)
    l
  end

  defp eval_name(acc, name, tmp_name) do
    if name |> String.at((name |> String.length) - 1) ==
      tmp_name |> String.at(0) |> String.downcase do
      acc ++ [tmp_name]
    else
      acc
    end
  end

  defp put_in_map([], acc, n1) do
    Map.put(acc, n1, nil)
  end

  defp put_in_map(t, acc, n1) do
    Map.put(acc, n1, t |> List.first)
  end
end
