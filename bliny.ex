defmodule Bliny do
  def bliny(order) do
    m = List.first(order)

    {s, _} = Enum.reduce(order, {Enum.into(1..m, []), m}, fn(x, acc) ->
      {list, m} = acc
      {list, m} = eval_diff(list, m, x)
      {list, m} = eval_eq(list, m, x)

      {list, m}
    end)

    length(s) == 0
  end


  def eval_diff(list, m, x) do
    if List.last(list) != x do
      {list ++ ((m + 1)..x |> Enum.to_list), m}
    else
      {list, m}
    end
  end


  def eval_eq(list, m, x) do
    if List.last(list) == x do
      {List.delete_at(list, length(list) - 1), Enum.max [x, m]}
    else
      {list, m}
    end
  end
end
