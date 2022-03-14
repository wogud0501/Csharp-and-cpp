template <typename T>
class Numeric_Iterator : public std::iterator <std::forward_iterator_tag, T>
{
	friend class Numeric_Range <T>;

private:
	Numeric_Range<T>& range;
	T value;

public:
	explicit Numeric_Iterator(Numeric_Range<T>& a_range) : range{ a_range }, value{ a_range.start } {};

	Numeric_Iterator& operator=(const Numeric_Iterator& src)
	{
		range = src.range;
		value = src.value;
	}

	T& operator*()
	{
		if (value == static_cast<T>(range.start + range.count * range.step))
		{
			throw std::logic_error("Can't dereference an end iterator.");
		}
		return value;
		Numeric_Iterator& operator++()
		{
			if (value == static_cast<T>(range.start + range.count * range.step))
			{
				throw std::logic_error("Can't increment an end iterator.");
			}
			auto temp = *this;
			value += range.step;
			return temp;
		}
	}
};