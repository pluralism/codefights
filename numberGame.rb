def numberGame(n, d)
  return 0 if n.length == 1
  return 1 if d == 1
  m = 0
  v = {}
  n2 = n.to_s.chars
  n2.each_with_index { |_, i|
    nd = n2.dup
    nd.delete_at i
    t = nd.map(&:to_i).join.to_i
    if t > 0 and t % d == 0 and !v.has_key? t
      v[t] = 1
      m = [m, numberGame(t.to_s, d - 1) + 1].max
    end
  }
  m
end
