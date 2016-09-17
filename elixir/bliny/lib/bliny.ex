defmodule Bliny do
  def bliny(order) do
    {s, _} = Enum.reduce(order, {Enum.into(1..List.first(order), []), List.first(order)}, fn(x, acc) ->
      {list, m} = acc
      {list, m} = eval_diff(list, m, x)
      eval_eq(list, m, x)
    end)
    length(s) == 0
  end

  def eval_diff(list, m, x) do
    cond do
      List.last(list) != x -> {list ++ ((m + 1)..x |> Enum.to_list), m}
      true -> {list, m}
    end
  end

  def eval_eq(list, m, x) do
    cond do
      List.last(list) == x -> {List.delete_at(list, length(list) - 1), Enum.max [x, m]}
      true -> {list, m}
    end
  end
end
