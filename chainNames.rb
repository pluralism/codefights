def chainNames n
  conns = Hash.new
  n.map { |n1|
    t = n.select { |n2| n1[-1] == n2[0].downcase }
    conns[n1] = t.empty? ? nil : t.first
  }
  n3, r = (conns.keys - conns.values).first, []
  (1..n.length).each do
    r << n3
    n3 = conns[n3]
  end
  r
end
